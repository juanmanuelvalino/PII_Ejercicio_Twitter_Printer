//------------------------------------------------------------------------------------
// <copyright file="TimeMachinePrinter.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------------
using System;

namespace Polymorphism
{
    public class TimeMachinePrinter : IPrinter
    {
        public void PrintTicket(Sale sale)
        {
            sale.DateTime = new DateTime(2002, 01, 01);
            Console.WriteLine(sale.GetTextToPrint());
        }
    }
}