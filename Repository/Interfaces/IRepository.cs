﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginProject.Repository
{
    public interface IRepository
    {
        void SaveData();
        void LoadData();  
    }
}
