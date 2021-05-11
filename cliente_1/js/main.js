const d = document;

let buscador = d.querySelector(".buscar-estado");
buscador.addEventListener("keypress", (e) => {
  console.log(e.target.value);
  let $estado = d.querySelectorAll(".datos-estados");
  console.log($estado);

  $estado.forEach((element) =>
    element.textContent.toLowerCase().includes(e.target.value)
      ? element.classList.remove("filter")
      : element.classList.add("filter")
  );
});



const getDatase = async () => {
  const $semaforo = d.getElementById("semaforo"),
    $red = d.querySelector(".red"),
    $orange = d.querySelector(".orange"),
    $yellow = d.querySelector(".yellow"),
    $green = d.querySelector(".green"),
    $redOcultar = d.querySelector(".red-ocultar");

  let printRed = "",
    printOrange = "",
    printYellow = "",
    PrintGreen = "";


  try {
    const respost = await fetch(`https://apirestcovid192.000webhostapp.com/api/semaforo.php`, {
      // const response = await fetch(`http://www.apidonaciones.somee.com/api/Donacion`, {
        // const response = await fetch(`http://covid-19.test/api/semaforo.php`, {
      method: "GET",
      headers: {
        "Content-Type": "application/json",
      },
      });
    
    if (!response.ok) {
      throw new Error ("No se a podido establecer conexión con la API" + status);
    }
 
    const post = await response.json();

    post.forEach((elemento) => {
      if (elemento.color === "red") {
        printRed += `
                <article class='text-${elemento.color} shadow-inner'>
                <p class='datos-estados'>${elemento.estado}<span class='etiqueta-roja'><br>Estado: ${elemento.estado}</br> <br>Casos: ${elemento.casos}</br> <br>Muertes:${elemento.muertes}</br></span><p>
                </article>
                `;
      }
      if (elemento.color === "green") {
        PrintGreen += `
                <article class='text-${elemento.color} shadow-inner'>
                <p class='datos-estados'>${elemento.estado}<span class='etiqueta-verde'><br>Estado: ${elemento.estado}</br> <br>Casos: ${elemento.casos}</br> <br> Muertes:${elemento.muertes}</br> </span><p>
                </article>
                `;
      }
      if (elemento.color === "yellow") {
        printYellow += `
                <article class='text-${elemento.color} shadow-inner'>
                <p class='datos-estados'>${elemento.estado}<span class='etiqueta-amarilla'><br>Estado: ${elemento.estado}</br> <br>Casos: ${elemento.casos}</br> <br>Muertes:${elemento.muertes}</br></span><p>
                </article>
                `;
      }
      if (elemento.color === "orange") {
        printOrange += `
                <article class='text-${elemento.color} shadow-inner'>
                <p class='datos-estados'>${elemento.estado}<span class='etiqueta-naranja'><br>Estado: ${elemento.estado}</br> <br>Casos: ${elemento.casos}</br>  <br>Muertes:${elemento.muertes}</br></span><p>
                </article>
                `;
      }
      
    });  
    $red.innerHTML = printRed;
    $orange.innerHTML = printOrange;
    $yellow.innerHTML = printYellow;
    $green.innerHTML = PrintGreen;

  } catch (error) {
    console.log(`Se produjo el siguiente ${error}`);
  }
};

getDatase();