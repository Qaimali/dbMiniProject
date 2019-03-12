using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMiniProject
{
    class student
    {
        private string registrationNumber;
        private string name;
        private string email;
        private string id;
        private string groupStatus;
        private string groupId;
        private string groupAssignmentDate;


        public string RegistrationNumber
        {
            get
            {
                return registrationNumber;
            }

            set
            {
                registrationNumber = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string GroupAssignmentDate
        {
            get
            {
                return groupAssignmentDate;
            }

            set
            {
                groupAssignmentDate = value;
            }
        }

        public string GroupId
        {
            get
            {
                return groupId;
            }

            set
            {
                groupId = value;
            }
        }

        public string GroupStatus
        {
            get
            {
                return groupStatus;
            }

            set
            {
                groupStatus = value;
            }
        }
    }
}
