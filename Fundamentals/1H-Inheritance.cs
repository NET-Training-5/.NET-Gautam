class A
{
    public int x;
}

//Single Inheritance
class B: A     //B inherits from A or B is of type A or A is parent of B. 
{
    public int y;
}

// Multilevel Inheritance
class C: B
{
    public int z;
}

interface ID
{

}

class E: B, ID
{

}
