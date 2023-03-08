namespace WFApp.Models;

public class StaffModel
{
	public string Id { get; set; } = string.Empty;
	public string NationalId { get; set; } = string.Empty;
	public string Name { get; set; } = string.Empty;
	public string PhoneNumber { get; set; } = string.Empty;
	public bool IsMale { get; set; }
	public string Email { get; set; } = string.Empty;
	public string Degree { get; set; } = string.Empty;
	public DateTime Birthday { get; set; } = DateTimePicker.MinimumDateTime;
	public string Address { get; set; } = string.Empty;
	public DateTime CheckInDate { get; set; } = DateTimePicker.MinimumDateTime;
}
