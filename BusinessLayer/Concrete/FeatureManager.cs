﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class FeatureManager:IFeatureService
    {
        IFeatureDal _featureDal;

        public FeatureManager(IFeatureDal featureDal)
        {
            _featureDal = featureDal;
        }

        public void TAdd(Feature t)
        {
            _featureDal.Insert(t);
        }

        public void TDelete(Feature t)
        {
            _featureDal.Delete(t);
        }

        public Feature TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Feature> TGetlist()
        {
            return _featureDal.GetList();
        }

        public void TUpdate(Feature t)
        {
            _featureDal.Update(t);
        }
    }
}
