﻿using Model;
using System.Collections.Generic;

namespace Service.Interface
{
    public interface IMunicipioService
    {
        bool Insert(MunicipioModel municipioModel);
        bool Update(MunicipioModel municipioModel);
        bool Delete(int id);
        List<MunicipioModel> GetAll();
        List<MunicipioModel> GetByUFCode(string UFCode);
        MunicipioModel GetById(int id);
    }
}
