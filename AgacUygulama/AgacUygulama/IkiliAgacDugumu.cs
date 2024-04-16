using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgacUygulama
{
    public class IkiliAgacDugumu
    {
        public object veri;
        public IkiliAgacDugumu sol;
        public IkiliAgacDugumu sag;
        public string dugumler;
        public IkiliAgacDugumu(object veri)
        {
            this.veri = veri;
            sol = null;
            sag = null;
        }
        public void PreOrder(IkiliAgacDugumu dugum)
        {
            if (dugum == null)
                return;

            Ziyaret(dugum);

            PreOrder(dugum.sol);
            PreOrder(dugum.sag);
        }

        private void Ziyaret(IkiliAgacDugumu dugum)
        {
            dugumler += dugum.veri + " ";
        }
        public void PostOrder(IkiliAgacDugumu dugum)
        {
            if (dugum == null)
                return;

            PostOrder(dugum.sol);
            PostOrder(dugum.sag);
            Ziyaret(dugum);
        }

        public void InOrder(IkiliAgacDugumu dugum)
        {
            if (dugum == null)
                return;

            InOrder(dugum.sol);
            Ziyaret(dugum);
            InOrder(dugum.sag);
        }

        public int DugumSayisi(IkiliAgacDugumu dugum)
        {
            int count = 0;
            if (dugum != null)
            {
                count = 1;
                count += DugumSayisi(dugum.sol);
                count += DugumSayisi(dugum.sag);

            }
            return count;
        }
        public int YaprakSayisi(IkiliAgacDugumu dugum)
        {
            int count = 0;
            if (dugum != null)
            {
                if ((dugum.sol==null)&&(dugum.sag==null))
                {
                    count = 1;
                }
                else
                { 
                    count = count + YaprakSayisi(dugum.sol) + YaprakSayisi(dugum.sag);
                }
            }
            return count;
        }
    }
}
