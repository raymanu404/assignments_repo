using Generic;
using Generic.Shapes;

GenericStack<int> intStack = new GenericStack<int>();
intStack.Push(2);
intStack.Push(3);
intStack.Push(4);

var item1 = intStack.Pop();
var item2 = intStack.Pop();

Console.WriteLine(item1);
Console.WriteLine(item2);

GenericStack<string> stringStack =  new GenericStack<string>();
stringStack.Push("asda");
stringStack.Push("abgja");
stringStack.Push("23");
stringStack.Push("random element");
stringStack.Push("last element");

var string1 =  stringStack.Pop();
var string2 = stringStack.Pop();

Console.WriteLine(string1);
Console.WriteLine(string2);

//Generic with Shape
GenericStack<Shape> shapes = new GenericStack<Shape>();
PushShapes(shapes);
DrawShapes(shapes);

shapes.Push(new Square(3));
DrawShape(PopShape(shapes));


void DrawShape<TShape> (TShape stack) where TShape : Shape
{
    stack.Draw();
}

void DrawShapes(IPopStack<Shape> shape){
    try
    {
        while (true)
        {
            shape.Pop().Draw();
        }

    }catch(InvalidOperationException ex)
    {
        Console.WriteLine(ex.Message);
        
    }
}

void PushShapes(IPushStack<Shape> shape)
{
    shape.Push(new Rectangle(10, 20));
    shape.Push(new Circle(30));
    shape.Push(new Rectangle(30, 30));

}

TShape PopShape <TShape> (IPopStack<TShape> shape)
{
    return shape.Pop();
}