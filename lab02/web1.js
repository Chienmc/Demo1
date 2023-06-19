const http = require('http')
const server = http.createServer((req,res) =>{
    res.statusCode = 200 //HTTP-OK
    res.setHeader("Content-Type","application/json")
    res.write('{"country" : "Viet Nam", "capital" : "Ha Noi"}')
    res.end()
})
server.listen(5000, () => {
    console.log("My website run successfully !")
    console.log("http://localhost:5000")
})
