using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;

namespace Business
{
    public class Mapper
    {
        public static TypeEntity Map<TypeModel, TypeEntity>(TypeModel Model)
        {

            MapperConfiguration Config = new MapperConfiguration(config => {
                config.CreateMap<TypeModel, TypeEntity>();
            });

            return (TypeEntity)
                    Convert
                    .ChangeType(
                        Config
                        .CreateMapper()
                        .Map<TypeModel, TypeEntity>(Model),
                        typeof(TypeEntity));

        }
    }
}
