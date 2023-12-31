import { ChangeEvent, Dispatch, KeyboardEventHandler, useState } from "react";


interface CustomInputProps {
  values: string[];
  setvalues: Dispatch<React.SetStateAction<string[]>>;
}
export default function CustomAuthorInput({ values, setvalues }: CustomInputProps) {
  const [inputValue, setInputValue] = useState("");

  const [error, setError] = useState<string | null>(null);

  const handleInputChange = (event: ChangeEvent<HTMLInputElement>) => {
    setInputValue(event.target.value);
    setError(null); // Clear error message when input changes
  };

  const handleInputKeyDown: KeyboardEventHandler<HTMLInputElement> = async (
    event
  ) => {
    if (event.key === "Enter" || event.key === ",") {
      event.preventDefault();
      const newItem = inputValue.trim();
      if (newItem !== "") {
  
          setvalues((prevList) => [...prevList, newItem]);
          setInputValue("");
        
      }
    }
  };

  return (
    <div
      className={`max-w-screen-xl mx-auto  focus:border-indigo-500 border rounded p-1 ${
        error ? "border-red-500" : "border-gray-300"
      }`}
    >
      <ul className="flex flex-wrap gap-2">
        {
          values ? <>
          
          {values.map((item, index) => (
            <li
              key={index}
              className="bg-blue-100 text-blue-800 text-xs font-medium  px-2.5 py-0.5 rounded dark:bg-blue-900 dark:text-blue-300"
            >
              {item}
            </li>
          ))}
          </>:"Loading..."
        }
      </ul>

      <div className="mb-4">
        <input
          type="text"
          placeholder="Type and press Enter or comma to add values"
          value={inputValue}
          onChange={handleInputChange}
          onKeyDown={handleInputKeyDown}
          className={`w-full py-2 rounded-md focus:outline-none `}
        />
      </div>

      {error && <p className="text-red-500">{error}</p>}
    </div>
  );
}
