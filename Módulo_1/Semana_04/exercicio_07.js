const fahrenheit = [ 0, 32, 45, 50, 75, 80, 99, 120 ];

const celsius = fahrenheit.map((temp) => Math.round((temp - 32) * 5 / 9));

for(let temp in fahrenheit){
    console.log(`F = ${fahrenheit[temp]} / C = ${celsius[temp]}`)
};