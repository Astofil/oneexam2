int N=Convert.ToInt32(Console.ReadLine());
int p=1,sum=1;
for(int i=1;i<=N;i++){
    p=p*2;
    sum+=p;
}
Console.WriteLine(sum);