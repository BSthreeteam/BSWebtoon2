using BSWebtoon.Admin.IDapperRepository;
using BSWebtoon.Model.Models;
using Coravel.Invocable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BSWebtoon.Admin.Service.JobService
{
    public class ActivityIsDelete : IInvocable
    {
        private readonly IDapperActivityRepository _dapperActivityRepository;

        public ActivityIsDelete(IDapperActivityRepository dapperActivityRepository)
        {
            this._dapperActivityRepository = dapperActivityRepository;
        }

        public async Task Invoke()
        {
            var allActivity = _dapperActivityRepository.SelectAll();

            var isStartActivity = allActivity.Where(a => a.ActivityStartTime < DateTime.UtcNow.AddHours(8)).ToList();
            var isEndActivity = allActivity.Where(a => a.ActivityEndTime < DateTime.UtcNow.AddHours(8)).ToList();

            OpenActivity(isStartActivity);
            DeleteActivity(isEndActivity);

            await Task.CompletedTask;
        }
        public void DeleteActivity(List<Activity> activities) // isDelete 0 = false , 1 = true
        {
            foreach (var activity in activities)
            {
                activity.IsDelete = true;
                _dapperActivityRepository.Update(activity);
            }
        }

        public void OpenActivity(List<Activity> activities)
        {
            foreach (var activity in activities)
            {
                activity.IsDelete = false;
                _dapperActivityRepository.Update(activity);
            }
        }
    }
}
