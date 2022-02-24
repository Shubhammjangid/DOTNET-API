﻿using NS.EMS.DATABASE.Entities;
using NS.EMS.MODEL;
using System;
using System.Collections.Generic;
using System.Text;

namespace NS.EMS.BUSSINESS
{
    public interface IBussiness
    {
        List<Information> GetInformation();

        Information DetailId(int id);

        bool AddInformation(Model model);

        bool Update(Information info);

        bool Delete(int id);
    }
}
