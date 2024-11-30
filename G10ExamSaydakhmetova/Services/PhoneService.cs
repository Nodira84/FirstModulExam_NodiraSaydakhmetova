using G10ExamSaydakhmetova.Models;

namespace G10ExamSaydakhmetova.Services;

public class PhoneService
{
    private List<Phone> phones;

    public PhoneService()
    {
        phones = new List<Phone>();
    }

    public Phone AddPhone(Phone phone)
    {
        phone.Id = Guid.NewGuid();
        phones.Add(phone);
        return phone;
    }

    public Phone GetPhoneById(Guid phoneId)
    {
        foreach (var phone in phones)
        {
            if (phone.Id == phoneId)
            {
                return phone;
            }
        }
        return null;
    }

    public bool DeletePhone(Guid phoneId)
    {
        var phoneFromDb = GetPhoneById(phoneId);
        if (phoneFromDb is null)
        {
            return false;
        }
        phones.Remove(phoneFromDb);
        return true;
    }

    public bool UpdatePhone(Phone updatingPhone)
    {
        var phoneFromDb = GetPhoneById(updatingPhone.Id);
        if (phoneFromDb is null)
        {
            return false;
        }
        var index = phones.IndexOf(phoneFromDb);
        phones[index] = updatingPhone;
        return true;
    }

    public List<Phone> GetAllPhones()
    {
        return phones;
    }
}
