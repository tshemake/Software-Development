#!/bin/bash
if [ $# -gt 0 ]
then
    while (( $# ))
    do
        echo $1
        shift
    done
fi