using Gestion.dinventaire.Backend.Models;
using Gestion.Inventaire.Model.Models;

namespace Gestion.dinventaire.Backend.DAL.Mappers
{
    public static class EmployeeMapper
    {
        public static Employee ToModel(this EmployeeEntity Entity)
        {
            Employee employee = new(
                FirstName: Entity?.firstName ?? string.Empty,
                LastName:Entity?.lastName?? string.Empty,

                Email: Entity?.Email ?? string.Empty,
                Password: Entity?.password ?? string.Empty,
                isActif: Entity?.IsActif ?? true
                );
            {

            Id: Entity?.Id.ToString();
            };
            return employee;

        }




        public static EmployeeEntity ToEntity(this Employee Model)
        {
            return new EmployeeEntity()
            {
                firstName = Model.firstName,
                lastName=Model.lastName,
                Email = Model.email,
                password = Model.password,

            };

        }

    }
}
