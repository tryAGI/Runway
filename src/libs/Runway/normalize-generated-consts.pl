#!/usr/bin/env perl
use strict;
use warnings;
no warnings 'once';

my $root = shift @ARGV // die "usage: normalize-generated-consts.pl <generated-dir>\n";

my @files;
{
    require File::Find;
    File::Find::find(
        sub {
            return unless -f $_ && $_ =~ /\.g\.cs\z/;
            push @files, $File::Find::name;
        },
        $root,
    );
}

for my $path (@files) {
    open my $in, '<', $path or die "open $path: $!";
    local $/;
    my $source = <$in>;
    close $in;

    $source =~ s{((?:bool)\??\s+\w+\s*(?:\{[^{}]*\}\s*)?=\s*)"True"(\s*[,;)])}{$1true$2}g;
    $source =~ s{((?:bool)\??\s+\w+\s*(?:\{[^{}]*\}\s*)?=\s*)"False"(\s*[,;)])}{$1false$2}g;
    $source =~ s{((?:sbyte|byte|short|ushort|int|uint|long|ulong|nint|nuint)\??\s+\w+\s*(?:\{[^{}]*\}\s*)?=\s*)"([+-]?\d+)"(\s*[,;)])}{$1$2$3}g;
    $source =~ s{
        (?<prefix>(?<type>float|double|decimal)\??\s+\w+\s*(?:\{[^{}]*\}\s*)?=\s*)
        "(?<value>[+-]?(?:\d+(?:\.\d+)?|\.\d+)(?:[eE][+-]?\d+)?)"
        (?<suffix>\s*[,;)])
    }{
        my $literal_suffix = $+{type} eq 'float' ? 'F' : $+{type} eq 'decimal' ? 'm' : '';
        "$+{prefix}$+{value}$literal_suffix$+{suffix}"
    }gex;

    open my $out, '>', $path or die "write $path: $!";
    print {$out} $source;
    close $out;
}
