using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    class UsersService
    {
        public static int UpdateUsers(Common.DTO.UsersDto user)
        {
            try
            {
                return DAL.UsersDal.UpdateUsers(Converters.UsersConverter.ToDalUsers(user));
            }
            catch (Exception e)
            {

                throw;
            }
        }
    }
}
