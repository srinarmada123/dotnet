using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace project_social_media
{
    public class BL
    {
        DAL d = new DAL();
        public int insert(EL el)
        {
            return d.insert(el);
        }
    }
}