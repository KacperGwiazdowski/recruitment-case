function fixage(age){
    let outputString ="";
    let filteredAge = age.filter(num => num>=18 && num<= 60);
    filteredAge.forEach(element => {
        outputString = outputString+element+",";
    });
    outputString = outputString.slice(0,-1);
    return outputString;
}