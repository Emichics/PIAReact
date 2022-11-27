import { Container, Form, FormGroup, Row, Col, Label, Input, Button } from "reactstrap";

const App = () => {
    return (
        <Container>
            <Form>
                <Row className="me-2">
                    <h1>Registro</h1>
                </Row>
                <Row className="me-2">
                    <Col md={4}>
                        <FormGroup>
                            <Label for="nombres">
                                Nombres
                            </Label>
                            <Input
                                id="nombres"
                                name="nombres"
                                placeholder="Fernanda"

                            />
                        </FormGroup>
                    </Col>
                    <Col md={4}>
                        <FormGroup>
                            <Label for="email">
                                Correo Electronico
                            </Label>
                            <Input
                                id="email"
                                name="email"
                                placeholder="fernandagomez@correo.com"
                                type="email"
                            />
                        </FormGroup>
                    </Col>
                </Row>
                <Row>
                    <Col md={4}>
                        <FormGroup>
                            <Label for="apellidos">
                                Apellidos
                            </Label>
                            <Input
                                id="apellidos"
                                name="apellidos"
                                placeholder="Gomez Contreras"

                            />
                        </FormGroup>
                    </Col>
                    <Col md={4}>
                        <FormGroup>
                            <Label for="telefono">
                                Telefono
                            </Label>
                            <Input
                                id="telefono"
                                name="telefono"
                                placeholder="814627837"
                                type="number"
                            />
                        </FormGroup>
                    </Col>
                </Row>
                <Row>
                    <Col md={4}>
                        <FormGroup>
                            <Label for="contrasena">
                                Contrasena
                            </Label>
                            <Input
                                id="contrasena"
                                name="contrasena"
                                placeholder="Contrasena *"
                                type="password"
                            />
                        </FormGroup>
                    </Col>
                    <Col md={4}>
                        <FormGroup>
                            <Label for="fecha">
                                Fecha de Nacimiento
                            </Label>
                            <Input
                                id="fecha"
                                name="fecha"
                                type="date"
                            />
                        </FormGroup>
                    </Col>
                </Row>
                <Row>
                    <Col md={4}>
                        <FormGroup>
                            <Label for="sitioWeb">
                                Sitio Web
                            </Label>
                            <Input
                                id="sitioWeb"
                                name="sitioWeb"
                                placeholder="www.fernandaphotography.com"
                            />
                        </FormGroup>
                    </Col>
                    <Col md={4}>
                        <FormGroup>
                            <Label for="hermanos">
                                Numero de Hermanos
                            </Label>
                            <Input
                                id="hermanos"
                                name="nHermanos"
                                placeholder="2"
                                type="number"
                            />
                        </FormGroup>
                    </Col>
                </Row>

                <Row>
                    <Col md={12}>
                        <Button color="primary">
                            Resgistrarse
                        </Button>
                    </Col>
                </Row>
            </Form>
        </Container>
    )
}

export default App;