using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinicManagementProject.Models;
using Microsoft.Extensions.Logging;

namespace ClinicManagementProject.Services
{
    public class DoctorScheduleRepo : IRepo<DoctorSchedule, List<int>> //List<int> is to pass composite key {Timeslot_Id, Doctor_Id}
    {
        private readonly ClinicManagementContext _context;
        private readonly ILogger<DoctorScheduleRepo> _logger;

        public DoctorScheduleRepo(ClinicManagementContext context, ILogger<DoctorScheduleRepo> logger)
        {
            _context = context;
            _logger = logger;
        }

        public bool Add(DoctorSchedule t)
        {
            throw new NotImplementedException();
        }

        public bool Delete(List<int> k) //deleting the entire schedule slot
        {
            try
            {
                var doctorSchedule = Get(k);
                _context.DoctorSchedules.Remove(doctorSchedule);
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                _logger.LogError("Unable to delete the timeslot" + k + " " + e.Message);
            }
            return false;
        }

        public bool Edit(List<int> k, DoctorSchedule t)
        {
            try
            {
                _context.Update(t);
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                _logger.LogError("Unable to update doctor schedule " + k + e.Message);
                return false;
            }

        }

        public DoctorSchedule Get(List<int> k)
        {
            try
            {
                var doctorSchedule = _context.DoctorSchedules.SingleOrDefault(ds => ds.Timeslot_Id == k[0] && ds.Doctor_Id == k[1]);
                return doctorSchedule;
            }
            catch (Exception e)
            {
                _logger.LogError("No slot with this id " + k + " " + e.Message);
            }
            return null;
        }
        public DoctorSchedule Get(int schId)
        {
            try
            {
                var doctorSchedule = _context.DoctorSchedules.SingleOrDefault(ds => ds.Timeslot_Id == schId);
                return doctorSchedule;
            }
            catch (Exception e)
            {
                _logger.LogError("No slot with this id " + schId + " " + e.Message);
            }
            return null;

        }
        public ICollection<DoctorSchedule> GetAll()
        {
            if (_context.DoctorSchedules.Count() == 0)
            {
                _logger.LogInformation("No schedule found");
                return null;
            }
            return _context.DoctorSchedules.ToList();
        }

        public ICollection<DoctorSchedule> GetAll(int id) //additional method to get schedule by doctor id 
        {
            if (_context.DoctorSchedules.Where(ds => ds.Doctor_Id == id).Count() == 0)
            {
                _logger.LogInformation("No schedule found");
                return null;
            }
            return _context.DoctorSchedules.Where(ds => ds.Doctor_Id == id).ToList();
        }
    }
}
