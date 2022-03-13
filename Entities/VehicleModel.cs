using Interview.Models;

namespace Interview.Entities;

public class VehicleModel
{
    /// <summary>
    /// Primary Key
    /// </summary>
    public int Id { get; set; }
    
    /// <summary>
    /// Name of the model.
    /// </summary>
    public string Name { get; set; } = "";
    
    /// <summary>
    /// Year of the model.
    /// </summary>
    public int Year { get; set; }
    
    /// <summary>
    /// Number of seats.
    /// </summary>
    public int Seats { get; set; }

    /// <summary>
    /// Drivetrain type.
    /// </summary>
    public DriveTrain DriveTrain { get; set; }

    /// <summary>
    /// Transmission.
    /// </summary>
    public Transmission Transmission { get; set; }
}