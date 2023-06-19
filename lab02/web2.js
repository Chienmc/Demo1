const http = require('http')
const port = 3000
const server = http.createServer((req,res) =>{
    res.statusCode = 200
    res.setHeader("Content-Type", "text/html")    
    switch (req.url){
        case '/':
            res.write("<h1 style='color: red;'>This is homepage</h1>")
            res.end()
        case '/api':
            res.write('{"university" : "Greenwich", "address" : "Pham Van Bach - Hanoi"}')
            res.end()
        case '/login':
            res.write("<form>")
            res.write("Username: <input type=text required> <br>")
            res.write('{"university" : "Greenwich", "address" : "Pham Van Bach - Hanoi"}')
            res.end()
    }
})
server.listen(5000, () => {
    console.log("My website run successfully !")
    console.log("http://localhost:5000")
})
