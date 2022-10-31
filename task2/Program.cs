int N=Convert.ToInt32(Console.ReadLine());
int[] array=new int[N];
int min,max,mn,mx,p;
min=array[0];
max=array[0];
mn=0;
mx=0;
for(int i=0;i<N;i++){
    array[i]=Convert.ToInt32(Console.ReadLine());
}
for(int i=1;i<N;i++){
    if(min>array[i])
    {
        min=array[i];
        mn=i;
    }
    if(max<array[i])
    {
        max=array[i];
        mx=i;
    }
}
if(mn>mx){
    p=mn;
    mn=mx;
    mx=mn;
}
for(int i=mn;i<=mx;i++){
    Console.WriteLine(array[i]);
}