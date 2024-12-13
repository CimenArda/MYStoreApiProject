using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class FeatureManager : IFeatureService
    {
        private readonly IFeatureDal _FeatureDal;

        public FeatureManager(IFeatureDal FeatureDal)
        {
            _FeatureDal = FeatureDal;
        }

        public void TDelete(int id)
        {
            _FeatureDal.Delete(id);
        }

        public List<Feature> TGetAllList()
        {
            return _FeatureDal.GetAllList();
        }

        public Feature TGetById(int id)
        {
            return _FeatureDal.GetById(id);
        }

        public void TInsert(Feature entity)
        {
            _FeatureDal.Insert(entity);
        }

        public void TUpdate(Feature entity)
        {
            _FeatureDal.Update(entity);
        }
    }
}
