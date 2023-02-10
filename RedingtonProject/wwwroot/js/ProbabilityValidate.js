const probA = document.getElementById('probA')
const probB = document.getElementById('probB')

const form = document.getElementById('ProbabilityCalculator')

const errorElement = document.getElementById('error')


form.addEventListener('Calculate', () => {

    if (0 <= probA.value <= 1 && 0 <= probB.value <= 1) {

    }
    else{
        messages.push('Entry fields A and B need to be equal to or between 0 and 1')
    }



})