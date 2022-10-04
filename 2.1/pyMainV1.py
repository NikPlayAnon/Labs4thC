import libV1 as Comp

#the first
print("the first im number")
num=input("import solid num ")
i=input("import imaninary num ")
imNum=Comp.ImaginaryNums(num,i)

#the second
print("the second im number")
num=input("import solid num ")
i=input("import imaninary num ")
imNum2=Comp.ImaginaryNums(num,i)

#the Summ
temp=imNum
temp.ImSumm(imNum2)
print(f"Summ ({imNum.ImPrint()}) + ({imNum2.ImPrint()}) = {temp.ImPrint()}")

#the Min
temp=imNum
temp.ImDif(imNum2)
print(f"Min ({imNum.ImPrint()}) - ({imNum2.ImPrint()}) = {temp.ImPrint()}")

#the Pow
temp=imNum
temp.ImPow(imNum2)
print(f"Pow ({imNum.ImPrint()}) * ({imNum2.ImPrint()}) = {temp.ImPrint()}")

#the Dev
temp=imNum
temp.ImDev(imNum2)
print(f"Dev ({imNum.ImPrint()}) / ({imNum2.ImPrint()}) = {temp.ImPrint()}")
