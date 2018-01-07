#!/bin/bash

ERROR="error"

calculate()
{
    local let "a=$1"
    local let "op=$2"
    local let "b=$3"
    local result=$ERROR
    if ! [[ -z "$a" || -z "$op" || -z "$b" ]]
    then
        case "$op" in
            +)
                let "result = a + b"
                ;;
            -)
                let "result = a - b"
                ;;
            "*")
                let "result = a * b"
                ;;
            /)
                let "result = a / b"
                ;;
            %)
                let "result = a % b"
                ;;
            "**")
                let "result = a ** b"
                ;;
        esac
    fi

    echo "$result"
}

main ()
{
    while :
    do
        read val1 op val2
        if [[ "$val1" == "exit" ]]
        then
            echo "bye"
            break
        fi

        local let "result=$( calculate $val1 "$op" $val2 )"
        echo "$result"
        
        if [[ "$result" == $ERROR ]]
        then
            break
        fi
    done
}

main