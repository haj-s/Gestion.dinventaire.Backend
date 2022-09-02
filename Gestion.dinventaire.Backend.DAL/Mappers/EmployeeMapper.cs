using Gestion.dinventaire.Backend.Models;
using Gestion.Inventaire.Model.Models;

namespace Gestion.dinventaire.Backend.DAL.Mappers
{
    public static class EmployeeMapper
    {
        public static Employee ToModel(this EmployeeEntity Entity)
        {
            Employee employee = new(
                userName: Entity?.username ?? string.Empty,

                Email: Entity?.email ?? string.Empty,
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
                username = Model.username,
                email = Model.email,
                password = Model.password,

            };

        }

    }
}
