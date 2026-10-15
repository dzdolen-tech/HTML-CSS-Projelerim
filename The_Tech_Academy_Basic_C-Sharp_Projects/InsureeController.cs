[HttpPost]
[ValidateAntiForgeryToken]
public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,SpeedingTickets,HasDUI,CoverageType,Quote")] Insuree insuree)
{
    if (ModelState.IsValid)
    {
        // 1. Start with a base of $50 / month
        decimal quote = 50.0m;

        // Calculate age accurately
        int age = DateTime.Now.Year - insuree.DateOfBirth.Year;
        if (insuree.DateOfBirth > DateTime.Now.AddYears(-age)) age--;

        // 2-4. Age rules
        if (age <= 18)
        {
            quote += 100.0m;
        }
        else if (age >= 19 && age <= 25)
        {
            quote += 50.0m;
        }
        else
        {
            quote += 25.0m;
        }

        // 5. Car year before 2000
        if (insuree.CarYear < 2000)
        {
            quote += 25.0m;
        }
        // 6. Car year after 2015
        else if (insuree.CarYear > 2015)
        {
            quote += 25.0m;
        }

        // 7 & 8. Porsche and 911 Carrera rules
        if (!string.IsNullOrEmpty(insuree.CarMake) && insuree.CarMake.Equals("Porsche", StringComparison.OrdinalIgnoreCase))
        {
            quote += 25.0m;
            if (!string.IsNullOrEmpty(insuree.CarModel) && insuree.CarModel.Equals("911 Carrera", StringComparison.OrdinalIgnoreCase))
            {
                quote += 25.0m; // Adds an additional $25 (total $50 for this model)
            }
        }

        // 9. Speeding tickets ($10 per ticket)
        quote += (insuree.SpeedingTickets * 10.0m);

        // 10. DUI (add 25%)
        if (insuree.HasDUI)
        {
            quote *= 1.25m;
        }

        // 11. Full coverage (add 50%)
        if (insuree.CoverageType)
        {
            quote *= 1.50m;
        }

        // Assign the calculated quote to the model property
        insuree.Quote = quote;

        db.Insurees.Add(insuree);
        db.SaveChanges();
        return RedirectToAction("Index");
    }

    return View(insuree);
}