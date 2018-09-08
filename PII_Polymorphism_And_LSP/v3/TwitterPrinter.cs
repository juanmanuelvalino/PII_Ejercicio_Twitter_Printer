//------------------------------------------------------------------------------------
// <copyright file="TwitterPrinter.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------------
using System;
using TwitterUCU;

namespace Polymorphism
{
    public class TwitterPrinter : IPrinter
    {
        public void PrintTicket(Sale sale)
        {
            IPrinter Print= new FilePrinter();
            sale.DateTime= DateTime.Now;
            var twitter = new TwitterApi("dtOgpyjBBXglAzMEjMMZtFf73", "Qzm0FxotJ9YyoXiGLJ4JI9IZFWmYvB4LWpteWPGVYofxSG4FnN", "1396065818-13uONd7FgFVXhW1xhUCQshKgGv4UOnKeDipg4cz", "HXtlP1SRnJCL5a37R98hFrIRlEIouZX3Ra4s6JuFOpXZF");
            twitter.Tweet(sale.GetTextToPrint()).Wait();
        }
    }
}