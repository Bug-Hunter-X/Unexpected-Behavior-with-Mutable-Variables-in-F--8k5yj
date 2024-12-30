let swap x y =
    let temp = x
    x <- y
    y <- temp
    (x,y)

let x, y = swap 10 20
printf "%d %d" x y

//Alternative using ref cell

let mutable xRef = { contents = 10 }
let mutable yRef = { contents = 20 }

let swapRef (xRef: ref<int>) (yRef: ref<int>) = 
    let temp = xRef.contents
    xRef.contents <- yRef.contents
    yRef.contents <- temp

swapRef xRef yRef
printf "%d %d" xRef.contents yRef.contents