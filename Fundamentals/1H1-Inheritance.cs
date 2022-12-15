interface IShape //making interface
{
    public float GetArea();

    public float GetPerimeter();
}
class Rectangle
{
    
    public Rectangle(float l, float b) //this is constructor 

    {
            lenght = l;
            width = b;
    }
    float lenght;
    float width;
    public float GetArea() => lenght * width;

    public float GetPerimeter() => 2 * (lenght + width);
}

class Square: Rectangle
{
    float side;
    public Square(float s): base(s, s)
    {

    }

}

class Circle: IShape
{
    float radius;

    public Circle(float r) => radius = r; //making constructor

    public float GetArea() => 3.14f * radius * radius;

    public float GetPerimeter() => 2 * 3.14f * radius;
}