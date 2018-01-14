#!/bin/bash
read -r a b # Читаем переменные, переданные на стандартный ввод
let i=a
let sum=0
while [ $i -le $b ]
do
    let sum+=i
    let i+=1
done
echo $sum