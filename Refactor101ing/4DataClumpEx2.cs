using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring101.DataClump2;

// 4.2
public class DataClump2
{
    public (double, double) AddPoint(Point a,Point b)
    {
        return (a.x+b.x,a.y+b.y);
    }
}

public class Point
{
    public double x { get; }
    public double y { get; }
    public Point(double x, double y)
    {
        this.x = x;
        this.y = y;
    }
    
}
