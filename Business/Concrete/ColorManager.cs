    using Business.Abstract;
using Business.Constanrs;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;
        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;

        }
        [ValidationAspect(typeof(ColorValidator))]
        public IResult Add(Color color)
        {

            IResult result = BusinessRules.Run(DontGiveSameColor(color.ColorName));
            _colorDal.Add(color);
            return new SuccessResult(Messages.ColorAdded);
        }

        public IDataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll());
        }

        public IDataResult<Color> GetById(int id)
        {
            return new SuccessDataResult<Color>(_colorDal.Get(p=> p.Id==id));
        }

        private IResult DontGiveSameColor(string colorName) 
        {
            var result=_colorDal.GetAll(p=>p.ColorName==colorName).Any();
            if (result) 
            {
                return new ErrorResult(Messages.ColorNameAlreadyExists);
            }
            return new SuccessResult();
        }
    }
}
