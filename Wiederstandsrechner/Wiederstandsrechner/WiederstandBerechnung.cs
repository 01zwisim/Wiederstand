﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class WiederstandBerechnung
    {
        private int r1;
        private int r2;
        private bool reihe;

        public void setR1(int wert)
        {
            r1 = wert;                                  
        }
        public void setR2(int wert)
        {
            r2 = wert;
        }
        public void Reihe(bool wert)
        {
            this.reihe = wert;
        }
        public double berechnen()
        {
            double ergebnis;
            if (reihe)
            {
                ergebnis = r1 + r2;
                return ergebnis;
            }
            else
            {
                ergebnis = (r1 * r2) / (r1 + r2);
                return ergebnis;
            }
        }

    }
}
//simon zwischenbrugger && lorenz almberger