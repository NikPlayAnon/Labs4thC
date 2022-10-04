
from re import A


class ImaginaryNums:
    num=0
    i=0
    
    def __init__(self,num,i):
        self.num=num
        self.i=i
    

    def ImPrint(self):
        if(self.num!=0):
            tempNum=f"{self.num}"
        else:
            tempNum=""
        if(self.i!=0):
            tempI=f"{self.i}"
        else:
            tempI=""
        #print(f"{tempNum} + {tempI}i")
        return (f"{tempNum} + {tempI}i")
    
    def ImSumm(self, obj):
        self.num=(int)(self.num)+(int)(obj.num)
        self.i=(int)(self.i)+(int)(obj.i)
    
    def ImDif(self, obj):
        self.num=(int)(self.num)-(int)(obj.num)
        self.i=(int)(self.i)-(int)(obj.i)
    
    def ImPow(self, obj):
        self.num=((int)(self.num)*(int)(obj.num))-((int)(self.i)*(int)(obj.i))
        self.i=((int)(self.i)*(int)(obj.num))-((int)(self.num)*(int)(obj.i))
    
    def ImDev(self, obj):
        a=(int)(self.num)
        b=(int)(self.i)
        c=(int)(obj.num)
        d=(int)(obj.i)
        self.num=((a*c+b*d)/((c*c)+(d*d)))
        self.i=(((b*c)-(a*d))/((c*c)+(d*d)))
