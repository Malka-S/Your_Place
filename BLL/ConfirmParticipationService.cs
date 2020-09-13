using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ConfirmParticipationService
    {
        public static int UpdateConfirmParticipation(Common.DTO.ConfirmParticipationDto cp)
        {
            try
            {
                return DAL.ConfirmParticipationDalcs.UpdateConfirmParticipation(Converters.ConfirmParticipationConverter.ToDalConfirmParticipation(cp));
            }
            catch (Exception e)
            {

                throw;
            }
        }
        public static int AddConfirmParticipation(Common.DTO.ConfirmParticipationDto cp)
        {
            try
            {
                return DAL.ConfirmParticipationDalcs.AddConfirmParticipation(Converters.ConfirmParticipationConverter.ToDalConfirmParticipation(cp));
            }
            catch (Exception e)
            {

                throw;
            }
        }
    }
}
