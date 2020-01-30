using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Service.Lib.Model;
using StockDb.Entities;

namespace Service.Lib.Mapper
{
    public static class StockMapper
    {
        public static Product ProductMap(ProductModel productModel)
        {
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<ProductModel, Product>(); });
            IMapper mapper = config.CreateMapper();
            return mapper.Map<ProductModel, Product>(productModel);
                
        }

        public static Category CategoryMap(CategoryModel categoryModel)
        {
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<CategoryModel, Category>(); });
            IMapper mapper = config.CreateMapper();
            return mapper.Map<CategoryModel, Category>(categoryModel);

        }

        public static Employee EmployeeMap(EmployeeModel employeeModel)
        {
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<EmployeeModel, Employee>(); });
            IMapper mapper = config.CreateMapper();
            return mapper.Map<EmployeeModel, Employee>(employeeModel);

        }

        public static EmployeeModel EmployeeModelMap(Employee employee)
        {
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<Employee, EmployeeModel>(); });
            IMapper mapper = config.CreateMapper();
            return mapper.Map<Employee, EmployeeModel>(employee);
        }

        public static Order OrderMap(OrderModel orderModel)
        {
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<OrderModel, Order>(); });
            IMapper mapper = config.CreateMapper();
            return mapper.Map<OrderModel, Order>(orderModel);

        }

    }
}
