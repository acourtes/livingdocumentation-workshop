using Flottio.Annotations;

/**
 * Fuel Card Monitoring is the analysis of every incoming fuel card transaction in order to detect potential fuel card abnormal behavior by drivers. 
 * 
 * By looking for abuse patterns and by cross-checking facts from various sources, it reports anomalies that are therefore investigated by the fleet management team. 
 * 
 * For example, a client using Fuel Card Monitoring with the GPS fleet-tracking features is able to bust an employee for padding hours, falsifying timesheets, and stealing fuel, or buying non-fuel goods with the fuel card.
 */
[assembly: BoundedContext("Fuel Card Monitoring", new[] { "fuelcard.png" })]
[assembly: HexagonalArchitecture.DomainModel("Testability + Independence from the frameworks and technologies", new[] { "DDD.Conformist" })]
[assembly: FunctionalCoreImperativeShell]
namespace Flottio.FuelCardMonitoring.Domain
{

}
