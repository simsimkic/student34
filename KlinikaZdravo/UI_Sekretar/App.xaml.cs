using ClassDiagram.Controller;
using ClassDiagram.Model.Medicine;
using ClassDiagram.Model.Rooms;
using ClassDiagram.Model.Users;
using ClassDiagram.Model.WorkingSchedule;
using ClassDiagram.Repository;
using ClassDiagram.Repository.Csv.Converter;
using ClassDiagram.Repository.Csv.Stream;
using ClassDiagram.Repository.Sequencer;
using ClassDiagram.Service.DoctorService;
using ClassDiagram.Service.ManagerService;
using ClassDiagram.Service.SecretaryService;
using ClassDiagram.Service.UserService;
using KlinikaZdravo.Controller;
using KlinikaZdravo.Repository;
using KlinikaZdravo.Repository.Csv.Converter;
using KlinikaZdravo.Service;
using System;
using System.Collections.Generic;
using System.Windows;
using ClassDiagram.Model.Questions;
using ClassDiagram.Service.PatientService;
using ClassDiagram.Model.DoctorExaminations;
using ClassDiagram.Service.ExaminationService;
using ClassDiagram.Service.MedicalRecordService;


namespace UI_sekretar
{

    public partial class App : Application
    {
        private const string EMPLOYEE_FILE = "C:\\Users\\Lenovo\\Desktop\\KONACNA\\klinikazdravlje\\KlinikaZdravo\\UI_sekretar\\Resources\\Data\\employee.csv";
        private const string VACATION_FILE = "C:\\Users\\Lenovo\\Desktop\\KONACNA\\klinikazdravlje\\KlinikaZdravo\\UI_sekretar\\Resources\\Data\\vacation.csv";
        private const string RENOVATION_FILE = "C:\\Users\\Lenovo\\Desktop\\KONACNA\\klinikazdravlje\\KlinikaZdravo\\UI_sekretar\\Resources\\Data\\renovations.csv";
        private const string ROOM_FILE = "C:\\Users\\Lenovo\\Desktop\\KONACNA\\klinikazdravlje\\KlinikaZdravo\\UI_sekretar\\Resources\\Data\\rooms.csv";
        private const string PERSONALDAY_FILE = "C:\\Users\\Lenovo\\Desktop\\KONACNA\\klinikazdravlje\\KlinikaZdravo\\UI_sekretar\\Resources\\Data\\personalDays.csv";
        private const string DRUG_FILE = "C:\\Users\\Lenovo\\Desktop\\KONACNA\\klinikazdravlje\\KlinikaZdravo\\UI_sekretar\\Resources\\Data\\drugs.csv";
        private const string PATIENT_FILE = "C:\\Users\\Lenovo\\Desktop\\KONACNA\\klinikazdravlje\\KlinikaZdravo\\UI_sekretar\\Resources\\Data\\patients.csv";
        private const string EQUIPMENT_FILE = "C:\\Users\\Lenovo\\Desktop\\KONACNA\\klinikazdravlje\\KlinikaZdravo\\UI_sekretar\\Resources\\Data\\equipment.csv";
        private const string WORKINGHOURSSCEDULE_FILE = "C:\\Users\\Lenovo\\Desktop\\KONACNA\\klinikazdravlje\\KlinikaZdravo\\UI_sekretar\\Resources\\Data\\workingHoursSchedule.csv";


        private const string EXAMINATION_FILE = "C:\\Users\\Lenovo\\Desktop\\KONACNA\\klinikazdravlje\\KlinikaZdravo\\UI_sekretar\\Resources\\Data\\examination.csv";
        private const string ALLERGIE_FILE = "C:\\Users\\Lenovo\\Desktop\\KONACNA\\klinikazdravlje\\KlinikaZdravo\\UI_sekretar\\Resources\\Data\\alergije.csv";
        private const string REFFERAL_FILE = "C:\\Users\\Lenovo\\Desktop\\KONACNA\\klinikazdravlje\\KlinikaZdravo\\UI_sekretar\\Resources\\Data\\reffl.csv";
        private const string VACCINE_FILE = "C:\\Users\\Lenovo\\Desktop\\KONACNA\\klinikazdravlje\\KlinikaZdravo\\UI_sekretar\\Resources\\Data\\vaccine.csv";
        private const string NOTIFICATION_FILE = "C:\\Users\\Lenovo\\Desktop\\KONACNA\\klinikazdravlje\\KlinikaZdravo\\UI_sekretar\\Resources\\Data\\notification.csv";
        private const string PRESCRIPTION_FILE = "C:\\Users\\Lenovo\\Desktop\\KONACNA\\klinikazdravlje\\KlinikaZdravo\\UI_sekretar\\Resources\\Data\\prescription.csv";
        private const string MEDICALRECORD_FILE = "C:\\Users\\Lenovo\\Desktop\\KONACNA\\klinikazdravlje\\KlinikaZdravo\\UI_sekretar\\Resources\\Data\\mr.csv";
       
        private const string ADDRESS_FILE = "C:\\Users\\Lenovo\\Desktop\\KONACNA\\klinikazdravlje\\KlinikaZdravo\\UI_sekretar\\Resources\\Data\\adress.csv";
        private const string CITY_FILE = "C:\\Users\\Lenovo\\Desktop\\KONACNA\\klinikazdravlje\\KlinikaZdravo\\UI_sekretar\\Resources\\Data\\city.csv";
        private const string CONTACT_FILE = "C:\\Users\\Lenovo\\Desktop\\KONACNA\\klinikazdravlje\\KlinikaZdravo\\UI_sekretar\\Resources\\Data\\contact.csv";
        private const string COUNTRY_FILE = "C:\\Users\\Lenovo\\Desktop\\KONACNA\\klinikazdravlje\\KlinikaZdravo\\UI_sekretar\\Resources\\Data\\country.csv";
        private const string USER_FILE = "C:\\Users\\Lenovo\\Desktop\\KONACNA\\klinikazdravlje\\KlinikaZdravo\\UI_sekretar\\Resources\\Data\\user.csv";
        private const string REGISTERED_USER_FILE = "C:\\Users\\Lenovo\\Desktop\\KONACNA\\klinikazdravlje\\KlinikaZdravo\\UI_sekretar\\Resources\\Data\\registeredUser.csv";
        private const string QUESTION_FILE = "C:\\Users\\Lenovo\\Desktop\\KONACNA\\klinikazdravlje\\KlinikaZdravo\\UI_sekretar\\Resources\\Data\\question.csv";

        private const string CSV_DELIMITER = ",";


        public App()
        {
            var employeeRepository = new EmployeeRepository(
            new CSVStream<Employee>(EMPLOYEE_FILE, new EmployeeCSVConverter(CSV_DELIMITER)), new LongSequencer());
            var employeeService = new EmployeesService(employeeRepository);
            _EmployeeController = EmployeeController.GetInstance(employeeService);

            var workingHoursScheduleRepository = new WorkingScheduleRepository(
            new CSVStream<WorkingHoursSchedule>(WORKINGHOURSSCEDULE_FILE, new WorkingScheduleCSVConverter(CSV_DELIMITER)), new LongSequencer());
            var workingHoursSceduleService = new WorkingTimeScheduleService(workingHoursScheduleRepository);
            _SWorkingHoursSchedule = SWorkingHoursSchedule.GetInstance(workingHoursSceduleService);

            var personalDayRepository = new PersonalDaysRepository(
             new CSVStream<PersonalDay>(PERSONALDAY_FILE, new PersonalDaysCSVConverter(CSV_DELIMITER)), new LongSequencer());
            var personalDayService = new PersonalDayService(personalDayRepository);
            _PersonalDayController = PersonalDayController.GetInstance(personalDayService);

            var roomRepository = new RoomRepository(
             new CSVStream<Room>(ROOM_FILE, new RoomCSVConverter(CSV_DELIMITER)), new LongSequencer());
            var roomAccountService = new RoomService(roomRepository);
            _RoomController = RoomController.GetInstance(roomAccountService);

            var renovationRepository = new RenovationRepository(
            new CSVStream<Renovation>(RENOVATION_FILE, new RenovationCSVConverter(CSV_DELIMITER)), new LongSequencer());
            var renovationService = new RenovationService(renovationRepository);
            _RenovationController = RenovationController.GetInstance(renovationService);

            var vacatiionRepository = new VacationScheduleRepository(
            new CSVStream<VacationSchedule>(VACATION_FILE, new VacationScheduleCSVConverter(CSV_DELIMITER)), new LongSequencer());
            var vacationService = new VacationScheduleService(vacatiionRepository);
            _VacationController = VacationController.GetInstance(vacationService);

            var drugRepository = new DrugRepository(
            new CSVStream<Drug>(DRUG_FILE, new DrugCSVConverter(CSV_DELIMITER)), new LongSequencer());
            var drugService = new DrugService(drugRepository);
            _DrugController = DrugController.GetInstance(drugService);

            var equipmentRepository = new EquipmentRepository(
            new CSVStream<Equipment>(EQUIPMENT_FILE, new EquipmentCSVConverter(CSV_DELIMITER)), new LongSequencer());
            var equipmentService = new EquipmentService(equipmentRepository);
            _EquipmentController = EquipmentController.GetInstance(equipmentService);

            var allergieRepository = new AllergieRepository(
            new CSVStream<Allergie>(ALLERGIE_FILE, new AllergieCSVConverter(CSV_DELIMITER)), new LongSequencer());
            var allergieService = new AllergieService(allergieRepository);
            allergieController = AllergieController.GetInstance(allergieService);
            allergieController.Create(new Allergie(1, "Penicilin"));

            var vaccineRepository = new VaccineRepository(
            new CSVStream<Vaccine>(VACCINE_FILE, new VaccineCSVConverter(CSV_DELIMITER)), new LongSequencer());
            var vaccineService = new VaccineService(vaccineRepository);
            vaccineController = VaccineController.GetInstance(vaccineService);
            vaccineController.Create(new Vaccine(1, DateTime.Now, "Protiv tetanusa"));

            var prescriptionRepository = new PrescriptionRepository(
            new CSVStream<Prescription>(PRESCRIPTION_FILE, new PrescriptionCSVConverter(CSV_DELIMITER)), new LongSequencer());
            var prescriptionService = new PrescriptionServicev(prescriptionRepository);
            precriptionController = PrescriptionController.GetInstance(prescriptionService);


            var refferalRepository = new RefferalLetterRepository(
            new CSVStream<ReferralLetter>(REFFERAL_FILE, new RefferalLetterCSVConverter(CSV_DELIMITER)), new LongSequencer());
            var refferalService = new RefferalService(refferalRepository);
            _RefferalLetterController = RefferalController.GetInstance(refferalService);
            List<Allergie> allergies = new List<Allergie>();
            List<Vaccine> vaccines = new List<Vaccine>();
            List<Prescription> prescriptions = new List<Prescription>();
            allergies.Add(new Allergie(1, "Penicilin"));
            vaccines.Add(new Vaccine(1, DateTime.Now, "Protiv tetanusa"));
            prescriptions.Add(new Prescription(1, "Analgan", "2Xdnevno, na 12h 2 tablete"));

            var MedicalRecordRepository = new MedicalRecordRepository(
            new CSVStream<MedicalRecord>(MEDICALRECORD_FILE, new MedicalRecordCSVConverter(CSV_DELIMITER)), new LongSequencer());
            var mrService = new MedicalRecordService(MedicalRecordRepository);
            MedicalRecordController = MedicalRecordDoctorController.GetInstance(mrService);
            MedicalRecord m = new MedicalRecord(1, allergies, vaccines, prescriptions);
            MedicalRecordController.Create(m);

            var EXRepository = new ExaminationRepository(
            new CSVStream<Examination>(EXAMINATION_FILE, new ExaminationCSVConverter(CSV_DELIMITER)), new LongSequencer());
            var EXService = new ExaminationService(EXRepository);
            examnationController = ExaminationController.GetInstance(EXService);

            NotificationRepository NotRepository = new NotificationRepository(
            new CSVStream<Notifications>(NOTIFICATION_FILE, new NotificationCSVConverter(CSV_DELIMITER)), new LongSequencer());
            var NotService = new NotificationsService(NotRepository);
            _NotificationssController = NotificationsController.GetInstance(NotService);

            var addressRepository = new AddressRepository(
            new CSVStream<Adress>(ADDRESS_FILE, new AddressCSVConverter(CSV_DELIMITER)), new LongSequencer());
            var addressService = new AddressService(addressRepository);
            _AddressController = AddressController.GetInstance(addressService);

            var cityRepository = new CityRepository(
            new CSVStream<City>(CITY_FILE, new CityCSVConverter(CSV_DELIMITER)), new LongSequencer());
            var cityService = new CityService(cityRepository);
            _CityController = CityController.GetInstance(cityService);

            var contactRepository = new ContactRepository(
            new CSVStream<Contact>(CONTACT_FILE, new ContactCSVConverter(CSV_DELIMITER)), new LongSequencer());
            var contactService = new ContactService(contactRepository);
            _ContactController = ContactController.GetInstance(contactService);

            var countryRepository = new CountryRepository(
            new CSVStream<Country>(COUNTRY_FILE, new CountryCSVConverter(CSV_DELIMITER)), new LongSequencer());
            var countryService = new CountryService(countryRepository);
            _CountryController = CountryController.GetInstance(countryService);

            var patientRepository = new PatientAccountRepository(
                 new CSVStream<Patient>(PATIENT_FILE, new PatientAccountCSVConverter(CSV_DELIMITER)), new LongSequencer());
            var patientService = new PatientsAccountsService(patientRepository);
            _PatientController = PatientAccountController.GetInstance(patientService);

            var registeredUserRepository = new RegisteredUserRepository(
                   new CSVStream<RegisteredUser>(REGISTERED_USER_FILE, new RegisteredUserCSVConverter(CSV_DELIMITER)), new LongSequencer());
            var registeredUserService = new RegisterUserService(registeredUserRepository);
            _RegisteredUserController = RegisteredUserController.GetInstance(registeredUserService);

            var userRepository = new UserRepository(
                   new CSVStream<User>(USER_FILE, new UserCSVConverter(CSV_DELIMITER)), new LongSequencer());
            var userService = new UserService(userRepository);
            _UserController = UserController.GetInstance(userService);

            var questionRepository = new QuestionRepository(
            new CSVStream<QuestionAndAnswer>(QUESTION_FILE, new QuestionCSVConverter(CSV_DELIMITER)), new LongSequencer());
            var questionService = new QuestionService(questionRepository);
            _QuestionController = MessageController.GetInstance(questionService);
        }

        public IController<Drug, long> _DrugController { get; private set; }
        public IController<VacationSchedule, long> _VacationController { get; private set; }
        public IController<PersonalDay, long>_PersonalDayController { get; private set; }
        public IController<Room, long> _RoomController { get; private set; }
        public IController<WorkingHoursSchedule, long> _SWorkingHoursSchedule { get; private set; }
        public IController<Renovation, long> _RenovationController { get; private set; }
        public IController<Employee, long> _EmployeeController { get; internal set; }
        public IController<Adress, long> _AddressController { get; private set; }
        public IController<City, long> _CityController { get; private set; }
        public IController<Contact, long> _ContactController { get; private set; }
        public IController<Country, long> _CountryController { get; private set; }
        public IController<User, long> _UserController { get; private set; }
        public IController<RegisteredUser, long> _RegisteredUserController { get; private set; }
        public IController<Notifications, long> _NotificationssController { get; private set; }
        public IController<ReferralLetter, long> _RefferalLetterController { get; private set; }
        public IController<Doctor, long> DoctorAccountController { get; private set; }
        public IController<Feedback, long> FeedbackController { get; private set; }
        public IController<Manager, long> ManagerAccountController { get; private set; }
        public IController<Report, long> ReportController { get; private set; }
        public IController<Secretary, long> SecretaryAccountController { get; private set; }
        public IController<Blog, long> ContentController { get; private set; }
        public IController<Patient, long> _PatientController { get; private set; }
        public IController<Equipment, long> _EquipmentController { get; private set; }
        public IController<Examination, long> examnationController { get; private set; }
        public IController<QuestionAndAnswer, long> _QuestionController { get; private set; }
        public IController<Allergie, long> allergieController { get; private set; }
        public IController<Vaccine, long> vaccineController { get; private set; }
        public IController<Prescription, long> precriptionController { get; private set; }
        public IController<MedicalRecord, long> MedicalRecordController { get; private set; }
    }
}
