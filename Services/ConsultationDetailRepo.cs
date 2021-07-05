using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinicManagementProject.Models;
using Microsoft.Extensions.Logging;

namespace ClinicManagementProject.Services
{
    public class ConsultationDetailRepo : IRepo<ConsultationDetail, List<int>>
    {
        private readonly ClinicManagementContext _context;
        private readonly ILogger<DoctorScheduleRepo> _logger;

        public ConsultationDetailRepo(ClinicManagementContext context, ILogger<DoctorScheduleRepo> logger)
        {
            _context = context;
            _logger = logger;
        }

        public bool Add(ConsultationDetail t)
        {
            throw new NotImplementedException();
        }

        public bool Delete(List<int> k)
        {
            try
            {
                var consultationDetail = Get(k);
                _context.ConsultationDetails.Remove(consultationDetail);
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                _logger.LogError("Unable to delete the Consultation Detail " + k + " " + e.Message);
            }
            return false;
        }

        public bool Edit(List<int> k, ConsultationDetail t)
        {
            try
            {
                _context.Update(t);
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                _logger.LogError("Unable to update Consultation Detail " + k + e.Message);
                return false;
            }
        }

        public ConsultationDetail Get(List<int> k)
        {
            try
            {
                //user TimeSlot ID to get timeSlot
                var docSchedule = _context.DoctorSchedules.SingleOrDefault(ds => ds.Timeslot_Id == k[0] && ds.Doctor_Id == k[2]);

                //use docSchedule time with other param to fetch Consultation detail
                var consultationDetail = _context.ConsultationDetails.SingleOrDefault(ds => ds.Timeslot == docSchedule.Time && ds.Patient_Id == k[1] && ds.Doctor_Id == k[2] && ds.Consultation_Status.ToUpper() == "OPENED");
                //var consultationDetail = _context.ConsultationDetails.SingleOrDefault(ds => ds.Patient_Id == k[0] && ds.Doctor_Id == k[1]);

                return consultationDetail;
            }
            catch (Exception e)
            {
                _logger.LogError("No slot with this id " + k + " " + e.Message);
            }
            return null;
        }

        public ConsultationDetail Get(int consId)
        {
            try
            {
                var consultationDetail = _context.ConsultationDetails.SingleOrDefault(ds => ds.Consultation_Id == consId);
                return consultationDetail;
            }
            catch (Exception e)
            {
                _logger.LogError("No slot with this id " + consId + " " + e.Message);
            }
            return null;
        }

        public ICollection<ConsultationDetail> GetAll()
        {
            if (_context.ConsultationDetails.Count() == 0)
            {
                _logger.LogInformation("No Consultation schedule found");
                return null;
            }
            return _context.ConsultationDetails.ToList();
        }

       
        public ICollection<ConsultationDetail> GetAll(int id)
        {
            if (_context.ConsultationDetails.Where(ds => ds.Doctor_Id == id).Count() == 0)
            {
                _logger.LogInformation("No schedule found");
                return null;
            }
            return _context.ConsultationDetails.Where(ds => ds.Doctor_Id == id).ToList();
        }
    }
}
