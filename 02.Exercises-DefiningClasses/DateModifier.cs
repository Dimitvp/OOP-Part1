using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class DateModifier
{
    public DateTime date1 { get; set; }
    public DateTime date2 { get; set; }

    public DateModifier(DateTime d1, DateTime d2)
    {
        this.date1 = d1;
        this.date2 = d2;
    }

    public int GetDiference()
    {
        return Math.Abs((this.date1 - this.date2).Days);
    }

}
