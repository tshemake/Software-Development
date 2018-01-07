#!/bin/bash

GCD ()  # takes one argument
{
    local let "a=$1"
    local let "b=$2"
    local result
    while [[ $a -ne 0 && $b -ne 0 ]]
    do
        if [[ $a -gt $b ]]
        then
            let "a%=b"
        else
            let "b%=a"
        fi
    done
    let "result=$a+$b"
    echo "$result"
}

main ()
{
    while :
    do
        read a b
        if [[ -z "$a" || -z "$b" ]]
        then
            break
        fi
        result=$(GCD $a $b)
        echo "GCD is ${result}"
    done
}

main
echo "bye"