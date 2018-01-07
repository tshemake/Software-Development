#!/bin/bash

while [ true ]
do
    echo "enter your name:" 
    read name
    if [[ -z "$name" ]]
    then
        break
    fi

    echo "enter your age:"
    read age
    if [[ $age -eq 0 ]]
    then
        break
    fi

    group="adult"
    if [[ $age -le 16 ]]
    then
        group="child"
    elif [[ $age -le 25 ]]
    then
        group="youth"
    fi
    echo "${name}, your group is ${group}"
done

echo "bye"