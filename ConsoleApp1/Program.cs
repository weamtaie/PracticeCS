// See https://aka.ms/new-console-template for more information

using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;




Box box1=new Box();
Box box2 = new Box();
Box box3 = new Box();

 double volume;

box1.SetLength(2);
box1.SetWidth(2);
box1.SetBredth(2);

volume=box1.GetVolume();
Console.WriteLine($"box 1 volume : {volume}");


box2.SetLength(3);
box2.SetWidth(3);
box2.SetBredth(3);

volume = box2.GetVolume();
Console.WriteLine($"box 2 volume : {volume}");



box3 = box1 + box2;
volume = box3.GetVolume();
Console.WriteLine($"volume of box3 is : {volume}");
public class Box
{
    private double length;
    private double width;
    private double bredth;

    

    public void SetLength(double len)
    {
        length = len;
    }
    public void SetWidth(double wid)
    {
        width = wid;
    }
    public void SetBredth(double bred)
    {
        bredth =bred ;
    }

    public double GetVolume()
    {
        return length*width*bredth;
    }

    public static Box operator + (Box a, Box b)
    {
        Box box=new Box();
        box.length = a.length+b.length;
        box.width = a.width+b.width;
        box.bredth= a.bredth+b.bredth;

        return box;

    }

}