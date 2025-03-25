function getWeirdName() {
    const first = ["Xylo", "Blarp", "Zog", "Vex", "Quorp"];
    const last = ["Magon", "Doodle", "Frizz", "Snorp", "Zizzle"];
    
    return first[Math.floor(Math.random() * first.length)] + 
           last[Math.floor(Math.random() * last.length)];
}

console.log("🛸 Your Alien Name:", getWeirdName());
