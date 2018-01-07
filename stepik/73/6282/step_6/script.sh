#!/bin/bash

msg="No students"

if [[ $# -ne 0 && $1 -ne 0 ]]
then
    case $1 in
        1)
            msg="1 student"
            ;;
        2 | 3 | 4)
            msg="$1 students"
            ;;
        *)
            msg="A lot of students"
    esac
fi

echo $msg