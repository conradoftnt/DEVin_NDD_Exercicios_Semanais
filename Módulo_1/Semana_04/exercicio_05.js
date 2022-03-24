var animais = [
    { animal: 'Cachorro', raca: 'Akita' },
    { animal: 'Cachorro', raca: 'Boxer' },
    { animal: 'Cachorro', raca: 'Dálmata' },
    { animal: 'Cachorro', raca: 'Pastor alemão' },
    { animal: 'Gato', raca: 'Persa' },
    { animal: 'Gato', raca: 'Sphynx' },
    { animal: 'Gato', raca: 'Siamês' },
]

animais.forEach((item) => {
    console.log(`Um ${item.animal} da raça ${item.raca}`)
})