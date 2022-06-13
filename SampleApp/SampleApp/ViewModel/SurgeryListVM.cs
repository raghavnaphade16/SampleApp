using System;
using System.Collections.ObjectModel;
using SampleApp.Models;

namespace SampleApp.ViewModel
{
	public class SurgeryListVM
	{
        public ObservableCollection<ActivityListModel> ItemList { get; set; }

        public SurgeryListVM()
		{
            ItemList = new ObservableCollection<ActivityListModel>();

            ItemList.Add(new ActivityListModel()
            {
                activityId = 1,
                activityName = "Vicharmanthan",
                activityInfo = "Discussions on hot topics in nation with different dignitaries",
                activityImgUrl = "vicharmanthan"
            });

            ItemList.Add(new ActivityListModel()
            {
                activityId = 2,
                activityName = "Swaravishkar",
                activityInfo = "Indian Classical Music Concert to support young artist and to promot pure indian classical music",
                activityImgUrl = "sw"
            });

            ItemList.Add(new ActivityListModel()
            {
                activityId = 3,
                activityName = "MiyaWaki Tree Plantation",
                activityInfo = "Tree planation for dense forest",
                activityImgUrl = "miyawaki"
            });

            ItemList.Add(new ActivityListModel()
            {
                activityId = 4,
                activityName = "Edu Support",
                activityInfo = "Give educations to students",
                activityImgUrl = "es"
            });

            ItemList.Add(new ActivityListModel()
            {
                activityId = 6,
                activityName = "Pic A Book",
                activityInfo = "improve reading and listing ability",
                activityImgUrl = "pab"
            });
            ItemList.Add(new ActivityListModel()
            {
                activityId = 7,
                activityName = "Pic A Book",
                activityInfo = "improve reading and listing ability",
                activityImgUrl = "pab"
            });
            ItemList.Add(new ActivityListModel()
            {
                activityId = 8,
                activityName = "Pic A Book",
                activityInfo = "improve reading and listing ability",
                activityImgUrl = "pab"
            });
            ItemList.Add(new ActivityListModel()
            {
                activityId = 9,
                activityName = "Pic A Book",
                activityInfo = "improve reading and listing ability",
                activityImgUrl = "pab"
            });

        }
	}
}

