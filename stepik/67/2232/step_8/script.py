a, b, c = (int(input()) for i in range(3))
print((a + c) // 60 + b, (a + c) % 60, sep='\n')
