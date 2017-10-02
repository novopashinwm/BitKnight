using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BiKnight
{
    public class Chess
    {
        byte wkx, wky;
        byte wbx, wby;
        byte wnx, wny;
        byte bkx, bky;

        public Chess()
        { 
        }

        public int  FoundCheckmates()
        {
            int count = 0;
            for (byte wk = 0; wk < 64; wk++)
            {
                getxy(wk, out wkx, out wky);
                for (byte wb = 0; wb < 64; wb++)
                {
                    if (wb == wk) continue;
                    getxy(wb, out wbx, out wby);
                    if ((wbx + wby) % 2 == 1) continue;
                    for (byte wn = 0; wn < 64; wn++)
                    {
                        if (wn == wk || wn == wb) continue;
                        getxy(wn, out wnx, out wny);
                        for (byte bk = 0; bk < 64; bk++)
                        {
                            if (bk == wk || bk == wb ||
                                bk == wn) continue;
                            getxy(bk, out bkx, out bky);
                            if (wkx == bkx - 1 || wkx == bkx) continue;
                            if (wkx == bkx + 1) continue;
                            if (wky == bky - 1 || wky == bky) continue;
                            if (wky == bky + 1) continue;
                            count++;
                        }
                    }
                }
            }
            return count;
        }

        void getxy(byte wk, out byte x, out byte y)
        {
            x = (byte)(wk % 8);
            y = (byte)(wk / 8);
        }


    }

}
