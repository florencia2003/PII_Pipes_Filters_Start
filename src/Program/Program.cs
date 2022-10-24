using System;
using CompAndDel.Pipes;
using CompAndDel.Filters;

namespace CompAndDel
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 1.
            PictureProvider provider = new PictureProvider();
            IPicture picture = provider.GetPicture("beer.jpg");

            PipeNull pipeNull = new PipeNull();

            FilterNegative filter2 = new FilterNegative();
            FilterGreyscale filter1 = new FilterGreyscale();

            PipeSerial piperSerial2 = new PipeSerial(filter2, pipeNull);
            PipeSerial piperSerial1 = new PipeSerial(filter1, piperSerial2);


            IPicture image = piperSerial1.Send(picture);
            pipeNull.Send(image);
        }
    }
}
