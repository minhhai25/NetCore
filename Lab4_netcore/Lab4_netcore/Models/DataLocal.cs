namespace Lab4_netcore.Models
{
    public class DataLocal
    {
        public static List<People> _peoples = new List<People>()
    {
        new People()
        {
            Id = 0,
            Name = "Devmaster",
            Email = "devmaster.edu.vn@gmail.com",
            Phone = "0978611889",
            Address = "25 Vũ Ngọc Phan",
            Avatar = "Images/Avatar/05.png",
            Birthday = Convert.ToDateTime("2012/09/22"),
            Bio = "Viện Công Nghệ Devmaster",
            Gender = 3
        },
        new People()
        {
            Id = 1,
            Name = "Trịnh Văn Chung",
            Email = "chungtrinh@gmail.com",
            Phone = "0978611889",
            Address = "25 Vũ Ngọc Phan",
            Avatar = "Images/Avatar/05.jpg",
            Birthday = Convert.ToDateTime("1979/05/25"),
            Bio = "Devmaster Academy",
            Gender = 1
        },
        new People()
        {
            Id = 2,
            Name = "Nguyễn Huy",
            Email = "huynguyen@gmail.com",
            Phone = "0912113113",
            Address = "Gia Lâm, Hà Nội",
            Avatar = "Images/Avatar/02.jpg",
            Birthday = Convert.ToDateTime("1999/02/12"),
            Bio = "Viện Công Nghệ Devmaster",
            Gender = 1
        },
        new People()
        {
            Id = 3,
            Name = "Tiểu Long Nữ",
            Email = "longntieu@gmail.com",
            Phone = "0904010102",
            Address = "Ba Đình, Hà Nội",
            Avatar = "Images/Avatar/03.jpg",
            Birthday = Convert.ToDateTime("2000/02/02"),
            Bio = "Nhân vật trong phim kiếm hiệp",
            Gender = 2
        },
        new People()
        {
            Id = 4,
            Name = "Pikachu",
            Email = "chupika@gmail.com",
            Phone = "0902114115",
            Address = "Quang Trung, Hà Đông",
            Avatar = "Images/Avatar/04.jpg",
            Birthday = Convert.ToDateTime("1997/12/12"),
            Bio = "Nhân vật trong phim hoạt hình",
            Gender = 2
        },
        new People()
        {
            Id = 5,
            Name = "Pikachu",
            Email = "chupika@gmail.com",
            Phone = "0902114115",
            Address = "Quang Trung, Hà Đông",
            Avatar = "Images/Avatar/04.jpg",
            Birthday = Convert.ToDateTime("1997/12/12"),
            Bio = "Nhân vật trong phim hoạt hình",
            Gender = 2
        }
    };
        /// <summary>
        /// GetPeoples: lấy danh sách sữ liệu people
        /// </summary>
        /// <returns></returns>
        public static List<People> GetPeoples()
        {
            return _peoples;
        }
        /// <summary>
        /// GetPeopleById : Lấy đối tượng theo id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        public static People? GetPeopleById(int id)
        {
            var people = _peoples.FirstOrDefault(x => x.Id == id);
            return people;
        }
        
    }

}
